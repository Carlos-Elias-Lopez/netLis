import { useState, useEffect } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import axios from "axios";
// import MuithemeProvider from "@mui/material/styles/ThemeProvider";
// import theme from "./themes/theme";
// import { BaseStructure } from "./components/BasicStructure/BaseStructure";
// import { RegistrarUsuario } from "./components/seguridad/RegistrarUsuario";
import { Header } from "./components/BasicStructure/Header";
import { NewOrder } from "./components/Orders/NewOrder";
import { Login } from "./components/seguridad/Login";

const App = () => {
  const baseURL = "https://localhost:44342";
  const [loading, setLoading] = useState(true);
  const [orderType, setOrderType] = useState([]);
  const [serviceType, setServiceType] = useState([]);
  const [patient, setPatient] = useState([]);
  const [hospital, setHospital] = useState([]);
  const [serviceArea, setServiceArea] = useState([]);
  const [doctor, setDoctor] = useState([]);
  const [test, setTest] = useState([]);
  const [auth, setAuth] = useState(true);

  const getOrderType = () => {
    setLoading(true);
    axios.get(`${baseURL}/api/TipoOrden`).then((res) => {
      setOrderType(res.data);
    });
    setLoading(false);
  };

  const getServiceType = () => {
    setLoading(true);
    axios.get(`${baseURL}/api/TipoServicio`).then((res) => {
      setServiceType(res.data);
    });
    setLoading(false);
  };

  const getPatient = () => {
    setLoading(true);
    axios.get(`${baseURL}/api/Paciente`).then((res) => {
      setPatient(res.data);
    });
    setLoading(false);
  };

  const getHospital = () => {
    setLoading(true);
    axios.get(`${baseURL}/api/Hospital`).then((res) => {
      setHospital(res.data);
    });
    setLoading(false);
  };

  const getServiceArea = () => {
    setLoading(true);
    axios.get(`${baseURL}/api/AreaServicio`).then((res) => {
      setServiceArea(res.data);
    });
    setLoading(false);
  };

  const getDoctor = () => {
    setLoading(true);
    axios.get(`${baseURL}/api/Medico`).then((res) => {
      setDoctor(res.data);
    });
    setLoading(false);
  };

  const getTest = () => {
    setLoading(true);
    axios.get(`${baseURL}/api/Examen`).then((res) => {
      setTest(res.data);
    });
    setLoading(false);
  };

  useEffect(() => {
    getOrderType();
    getServiceType();
    getPatient();
    getHospital();
    getServiceArea();
    getDoctor();
    getTest();
  }, []);

  return loading ? (
    <h1>Cargando</h1>
  ) : auth ? (
    <>
      <Header />
      <Router>
        <Routes>
          <Route
            path="/order/new"
            exact
            element={
              <NewOrder
                orderType={orderType}
                serviceType={serviceType}
                patient={patient}
                hospital={hospital}
                serviceArea={serviceArea}
                doctor={doctor}
                test={test}
              />
            }
          />
        </Routes>
      </Router>
    </>
  ) : (
    <Login />
  );
};

export default App;
