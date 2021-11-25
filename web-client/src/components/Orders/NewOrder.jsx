import React, { useState } from "react";
import { Grid, TextField, Typography } from "@mui/material";

export const NewOrder = () => {
  const [order, setOrder] = useState({
    patient: "",
    orderType: "",
    serviceType: "",
    hospital: "",
    department: "",
    doctor: "",
  });

  const orderHandler = (e) => {
    const { name, value } = e.target;
    setOrder((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  return (
    <div className="container">
      <div className="mb-3"></div>
      <h2 className="mb-3">Creando una nueva orden</h2>
      <h3 className="mb-3">Datos de la orden</h3>
      <div className="row mb-3">
        <div className="mb-3 col-12">
          <label htmlFor="patient" className="form-label">
            Paciente
          </label>
          <input
            name="patient"
            type="text"
            className="form-control"
            id="patient"
            value={order.patient}
            onChange={orderHandler}
            placeholder="Nombre o número de expendiente del paciente"
          />
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
            onChange={orderHandler}
          >
            <option value="sangre">Sangre</option>
            <option value="orina">Orina</option>
          </select>
        </div>
        <div className="mb-3 col-12 col-md-6">
          <label htmlFor="serviceType" className="form-label">
            Tipo de servicio
          </label>
          <select
            name="serviceType"
            value={order.serviceType}
            onChange={orderHandler}
            className="form-select"
            id="serviceType"
          >
            <option value="inss">INSS</option>
            <option value="convenioinss">Convenio INNS</option>
            <option value="pame">PAME</option>
          </select>
        </div>
      </div>
      <h3 className="mb-3">Origen</h3>
      <div className="row mb-3">
        <div className="mb-3 col-12">
          <label htmlFor="hospital" className="form-label">
            Hospital
          </label>
          <input
            name="hospital"
            value={order.hospital}
            onChange={orderHandler}
            type="text"
            className="form-control"
            id="hospital"
            placeholder="Nombre o código del hospital"
          />
        </div>
        <div className="mb-3 col-12 col-md-6">
          <label htmlFor="department" className="form-label">
            Área de servicio
          </label>
          <select
            name="department"
            value={order.department}
            onChange={orderHandler}
            className="form-select"
            id="department"
          >
            <option value="oncologia">Oncología</option>
            <option value="pediatria">Pediatría</option>
          </select>
        </div>
        <div className="mb-3 col-12 col-md-6">
          <label htmlFor="doctor" className="form-label">
            Médico
          </label>
          <input
            name="doctor"
            value={order.doctor}
            onChange={orderHandler}
            type="text"
            className="form-control"
            id="doctor"
            placeholder="Nombre o código del médico"
          />
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
    </div>
  );
};
