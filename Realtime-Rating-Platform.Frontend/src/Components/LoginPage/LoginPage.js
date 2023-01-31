import { Button, Checkbox, FormControl, FormControlLabel, FormGroup, IconButton, InputAdornment, InputLabel, OutlinedInput, TextField } from '@mui/material'
import React from 'react'
import Visibility from '@mui/icons-material/Visibility';
import VisibilityOff from '@mui/icons-material/VisibilityOff';
import cls from './LoginPage.module.scss'
import { NavLink } from 'react-router-dom';





export default function LoginPage(props) {
  
  const [showPassword, setShowPassword] = React.useState(false);

  const handleClickShowPassword = () => setShowPassword((show) => !show);

  const handleMouseDownPassword = (event) => event.preventDefault();
    
  const signInHandler = () => props.setAuth(true)
    
  
  
  return (
    <div className={cls.Login}>
      <div className={cls.LoginWindow}>
        <div className={cls.Container}>
          <h2>Kirish</h2>
          <b>Login</b>
          <TextField id="outlined-basic" label="Loginni kiriting" variant="outlined" sx={{width: '100%', marginTop: '8px'}}/>
          
          <b style={{marginTop: '20px'}}>Parol</b>
          <FormControl sx={{ width: '100%', margin: '8px auto ' }} variant="outlined">
          <InputLabel htmlFor="outlined-adornment-password">Password</InputLabel>
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

        <FormGroup>
          <FormControlLabel control={<Checkbox defaultChecked />} label="Eslab qolish" />
        </FormGroup>


        <NavLink to="/signup">Ro'yxatdan o'tish</NavLink>
        <div className={cls.buttonContainer}>
          <Button variant="contained" color='success' onClick={signInHandler}>Kirish</Button>
        </div>
        

        </div>
      </div>
    </div>
  )
}
