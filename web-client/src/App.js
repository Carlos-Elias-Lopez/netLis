import MuithemeProvider from "@mui/material/styles/ThemeProvider";
import theme from "./themes/theme";
import { BaseStructure } from "./components/BasicStructure/BaseStructure";
import { RegistrarUsuario } from "./components/seguridad/RegistrarUsuario";
import { Header } from "./components/BasicStructure/Header";
import { NewOrder } from "./components/Orders/NewOrder";

const App = () => {

  

  return (
    <MuithemeProvider theme={theme}>
      <Header />
      <NewOrder />
    </MuithemeProvider>
  );
};

export default App;
