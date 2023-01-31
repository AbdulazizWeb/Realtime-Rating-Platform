import { Button, FormControl, IconButton, InputAdornment, InputLabel, OutlinedInput, TextField } from '@mui/material'
import React from 'react'
import Visibility from '@mui/icons-material/Visibility';
import VisibilityOff from '@mui/icons-material/VisibilityOff';
import cls from './SignupPage.module.scss'
import { NavLink } from 'react-router-dom';
import axios, { Axios } from 'axios'

export default function LoginPage() {
  const [showPassword, setShowPassword] = React.useState(false);
  const [data, setData] = React.useState({fullname: "", email: "", password: ""})
  const baseURL = "http://127.0.0.1:8888"

  const handleClickShowPassword = () => setShowPassword((show) => !show);

  const handleMouseDownPassword = (event) => {
    event.preventDefault();
  };

  const onSubmitHandler = async (event) => {
    event.preventDefault(); 
    const resp = await request("https://zohiddev.uz/auth/register", "GET")
    console.log(resp);
  }
  const onInputHandler = (event, key) => {
    data[key] = event.target.value
  }
  
  return (
    <div className={cls.Signup}>
      <div className={cls.SignupWindow}>
        <form onSubmit={onSubmitHandler} className={cls.Container}>
          <h2>Ro'yxatdan o'tish</h2>
          <b>Ism, Familiya</b>
          <TextField onChange={(e) => onInputHandler(e, "fullname")} id="outlined-basic" label="Ism,familiyani kiriting" variant="outlined" sx={{width: '100%', marginTop: '8px'}}/>
          <b>Login</b>
          <TextField onChange={(e) => onInputHandler(e, "email")} type="email" id="outlined-basic" label="Emailni kiriting" variant="outlined" sx={{width: '100%', marginTop: '8px'}}/>
          
          <b style={{marginTop: '8px'}}>Parol</b>
          <FormControl sx={{ width: '100%', margin: '8px auto 15px' }} variant="outlined">
          <InputLabel htmlFor="outlined-adornment-password">Parolni kiriting</InputLabel>
          <OutlinedInput
          
            id="outlined-adornment-password"
            type={showPassword ? 'text' : 'password'}
            endAdornment={
              <InputAdornment position="end">
                <IconButton
                  aria-label="toggle password visibility"
                  onClick={handleClickShowPassword}
                  onMouseDown={handleMouseDownPassword}
                  edge="end"
                >
                  {showPassword ? <VisibilityOff /> : <Visibility />}
                </IconButton>
              </InputAdornment>
            }
            label="Password"
          />
        </FormControl>



        <b style={{}}>Parolni tasdiqlash</b>
          <FormControl sx={{ width: '100%', margin: '8px auto 15px' }} variant="outlined">
          <InputLabel htmlFor="outlined-adornment-password">Parolni tasdiqlang</InputLabel>
          <OutlinedInput
            onChange={(e) => onInputHandler(e, "password")}
            id="outlined-adornment-password"
            type={showPassword ? 'text' : 'password'}
            endAdornment={
              <InputAdornment position="end">
                <IconButton
                  aria-label="toggle password visibility"
                  onClick={handleClickShowPassword}
                  onMouseDown={handleMouseDownPassword}
                  edge="end"
                >
                  {showPassword ? <VisibilityOff /> : <Visibility />}
                </IconButton>
              </InputAdornment>
            }
            label="Password"
          />
        </FormControl>


        <NavLink to="/">Kirish</NavLink>
        <div className={cls.buttonContainer}>
          <Button type='submit' variant="contained" color='primary'>Ro'yxatdan o'tish</Button>
        </div>
        

        </form>
      </div>
    </div>
  )
}



export async function request(url, method, data = null) {
  try {
      const headers = {}
      let body
      if (data) {
          headers['Content-Type'] = 'application/json'
              body = JSON.stringify(data)
      }

      const response = await  fetch(url, {
          method,
          headers,
          body,
          mode: 'no-cors'
      })
      return await response.json()
  }

  catch (e) {
      console.warn('Error', e.message)
  }
}