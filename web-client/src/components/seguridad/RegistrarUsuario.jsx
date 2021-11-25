import React from "react";
import { Container, Typography, Grid, TextField, Button } from "@mui/material";
import style from "../../themes/Tools/Style";

export const RegistrarUsuario = () => {
  return (
    <Container component="main" maxWidth="md" justify="center">
      <div style={style.paper}>
        <Typography component="h1" variant="h5">
          Registrar usuario
        </Typography>
        <form style={style.form}>
          <Grid container spacing={2}>
            <Grid item xs={12} md={6}>
              <TextField
                name="nombre"
                variant="outlined"
                fullWidth
                label="Su nombre"
                autoComplete="off"
              />
            </Grid>
            <Grid item xs={12} md={6}>
              <TextField
                name="apellido"
                variant="outlined"
                fullWidth
                label="Su apellido"
                autoComplete="off"
              />
            </Grid>
            <Grid item xs={12} md={6}>
              <TextField
                name="username"
                variant="outlined"
                fullWidth
                label="Su nombre de usuario"
                autoComplete="off"
              />
            </Grid>
            <Grid item xs={12} md={6}>
              <TextField
                name="password"
                variant="outlined"
                type="password"
                fullWidth
                label="Cree una contraseña"
                autoComplete="off"
              />
            </Grid>
            <Grid item xs={12} md={6}>
              <TextField
                name="confirmation"
                variant="outlined"
                type="password"
                fullWidth
                label="Confirme su contraseña"
                autoComplete="off"
              />
            </Grid>
          </Grid>
          <Grid container justify="center">
            <Grid item xs={12} md={6}>
              <Button
                type="submit"
                fullWidth
                variant="contained"
                color="primary"
                size="large"
                style={style.submit}
              >
                Crear
              </Button>
            </Grid>
          </Grid>
        </form>
      </div>
    </Container>
  );
};
