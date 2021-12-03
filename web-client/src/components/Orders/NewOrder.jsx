import React, { useState } from "react";
// import { Grid, TextField, Typography } from "@mui/material";
import axios from "axios";

export const NewOrder = (props) => {
  const defaultState = {
    patient: "",
    orderType: "",
    serviceType: "",
    hospital: "",
    department: "",
    doctor: "",
    note: "",
    test: [],
    appointmentDate: new Date().toISOString().slice(0, 16),
  };

  const [order, setOrder] = useState(defaultState);
  const [orderTypeName, setOrderTypeName] = useState("Cita");

  const orderHandler = (e) => {
    const { name, value } = e.target;
    setOrder((prev) => ({
      ...prev,
      [name]: value,
    }));

    if (name === "orderType") {
      const ot = props.orderType.find((o) => o.idTipoOrden === value);
      setOrderTypeName(ot.descripcion);
    }
    // console.log(value);
  };

  const addExam = (e) => {
    const { id, checked } = e.target;
    const testAux = order.test;

    if (checked) {
      testAux.push(id);
    } else {
      testAux.splice(testAux.indexOf(id), 1);
    }

    setOrder((prev) => ({
      ...prev,
      test: testAux,
    }));
  };

  const save = (e) => {
    e.preventDefault();

    const randomNum = parseInt(Math.random() * 100000000000).toString();

    const data = {
      nOrden: randomNum,
      idtblMedico: order.doctor,
      idPaciente: order.patient,
      idTipoServicio: order.serviceType,
      idTipoOrden: order.orderType,
      asistencia: "Asistió",
      observaciones: order.note,
      fechaOrden: order.appointmentDate,
      ListExamen: order.test,
    };

    if (
      order.patient !== "" &&
      order.orderType !== "" &&
      order.serviceType !== "" &&
      order.doctor !== "" &&
      order.test !== []
    ) {
      console.log(order);
      axios.post("https://localhost:44342/api/Orden", data);
      window.location.href = `/order/new/barcode/${randomNum}`;
      //setOrder(defaultState);
    }
  };

  return (
    <div className="container">
      <div className="mb-3"></div>
      <h2 className="mb-3">Creando una nueva orden</h2>
      <form onSubmit={save}>
        <h3 className="mb-3">Datos de la orden</h3>
        <div className="row mb-3">
          <div className="mb-3 col-12">
            <label htmlFor="patient" className="form-label">
              Paciente
            </label>

            <select
              name="patient"
              id="patient"
              className="form-select"
              value={order.patient}
              onClick={orderHandler}
              onChange={orderHandler}
            >
              {props.patient.map((p) => {
                return (
                  <option
                    key={p.idPaciente}
                    value={p.idPaciente}
                  >{`${p.primerNombre} ${p.segundoNombre} ${p.primerApellido} ${p.segundoApellido} - ${p.numIdentificacion}`}</option>
                );
              })}
            </select>
          </div>
          <div className="mb-3 col-12 col-md-6">
            <label htmlFor="orderType" className="form-label">
              Tipo de orden
            </label>
            <select
              name="orderType"
              className="form-select"
              id="orderType"
              value={order.orderType}
              onClick={orderHandler}
              onChange={orderHandler}
            >
              {props.orderType.map((o) => {
                return (
                  <option key={o.idTipoOrden} value={o.idTipoOrden}>
                    {o.descripcion}
                  </option>
                );
              })}
            </select>
          </div>

          <div className="mb-3 col-12 col-md-6">
            <label htmlFor="serviceType" className="form-label">
              Tipo de servicio
            </label>
            <select
              name="serviceType"
              value={order.serviceType}
              onClick={orderHandler}
              onChange={orderHandler}
              className="form-select"
              id="serviceType"
            >
              {props.serviceType.map((s) => {
                return (
                  <option key={s.idTipoServicio} value={s.idTipoServicio}>
                    {s.descripcion}
                  </option>
                );
              })}
            </select>
          </div>

          {orderTypeName === "Cita" ? (
            <div className="mb-3 col-12 col-md-6">
              <label htmlFor="appointmentDate" className="form-label">
                Fecha de la cita
              </label>
              <input
                type="datetime-local"
                name="appointmentDate"
                id="appointmentDate"
                className="form-control"
                value={order.appointmentDate}
                onChange={(event) => orderHandler(event)}
              />
              <p></p>
            </div>
          ) : (
            ""
          )}

          <div className="mb-3 col-12 col-md-6">
            <label htmlFor="doctor" className="form-label">
              Médico
            </label>

            <select
              name="doctor"
              id="doctor"
              onChange={orderHandler}
              onClick={orderHandler}
              value={order.doctor}
              className="form-select"
            >
              {props.doctor.map((d) => {
                return (
                  <option
                    key={d.idTblMedico}
                    value={d.idTblMedico}
                  >{`${d.nombres} ${d.apellidos} - ${d.codMinsa}`}</option>
                );
              })}
            </select>
          </div>
        </div>

        <h3 className="mb-3" hidden>
          Origen
        </h3>
        <div className="row mb-3" hidden>
          <div className="mb-3 col-12">
            <label htmlFor="hospital" className="form-label">
              Hospital
            </label>
            <select
              name="hospital"
              id="hospital"
              className="form-select"
              onClick={orderHandler}
              onChange={orderHandler}
              value={order.hospital}
            >
              {props.hospital.map((h) => {
                return (
                  <option key={h.idHospital} value={h.idHospital}>
                    {h.descripcion}
                  </option>
                );
              })}
            </select>
          </div>

          <div className="mb-3 col-12 col-md-6">
            <label htmlFor="department" className="form-label">
              Área de servicio
            </label>
            <select
              name="department"
              value={order.department}
              onClick={orderHandler}
              onChange={orderHandler}
              className="form-select"
              id="department"
            >
              {props.serviceArea.map((s) => {
                return (
                  <option key={s.idAreaLabServicio} value={s.idAreaLabServicio}>
                    {s.descripcion}
                  </option>
                );
              })}
            </select>
          </div>

          <div className="mb-3 col-12 col-md-6">
            <label htmlFor="doctor" className="form-label">
              Médico
            </label>

            <select
              name="doctor"
              id="doctor"
              onChange={orderHandler}
              onClick={orderHandler}
              value={order.doctor}
              className="form-select"
            >
              {props.doctor.map((d) => {
                return (
                  <option
                    key={d.idTblMedico}
                    value={d.idTblMedico}
                  >{`${d.nombres} ${d.apellidos} - ${d.codMinsa}`}</option>
                );
              })}
            </select>
          </div>
        </div>

        <h3 className="mb-3">Observaciones</h3>
        <div className="row mb-3">
          <div className="mb-3 col-12">
            <label htmlFor="note" className="form-label">
              Observaciones
            </label>
            <textarea
              name="note"
              value={order.note}
              onChange={orderHandler}
              type="text"
              className="form-control"
              id="doctor"
              placeholder="Observaciones"
            />
          </div>
        </div>

        <h3 className="mb-3">Exámenes</h3>
        <div className="row mb-3">
          <div className="mb-3 col-12 col-md-6">
            <div className="border border-1 border-dark overflow-auto rounded-3 h-10 p-2">
              {props.test.map((t) => {
                return (
                  <div key={t.idExamen}>
                    <input
                      className="form-check-input"
                      type="checkbox"
                      id={t.idExamen}
                      onClick={(event) => addExam(event)}
                    />
                    <label
                      className="form-check-label"
                      htmlFor="flexCheckDefault"
                    >
                      {t.descripcion}
                    </label>
                  </div>
                );
              })}
            </div>
          </div>
        </div>

        <div className="row mb-3">
          <div className="col-12 col-md-6 col-lg-2 mb-1">
            <button type="submit" className="btn btn-primary w-100">
              Guardar
            </button>
          </div>
          <div className="col-12 col-md-6 col-lg-2 mb-1">
            <button type="submit" className="btn btn-secondary w-100">
              Cancelar
            </button>
          </div>
        </div>
      </form>
    </div>
  );
};
