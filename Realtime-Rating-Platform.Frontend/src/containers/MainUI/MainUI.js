import { CssBaseline } from '@mui/material';
import Box from '@mui/material/Box';
import React from 'react'
import AppBar from './AppBar/AppBar';
import Drawer from './Drawer/Drawer';
import BodySection from './BodySection/BodySection';
import { useTheme } from '@mui/material/styles';
import { createBrowserHistory } from '@remix-run/router';

const data = [
  { to: '/', title: 'Home page', key: 'home' },
  { to: '/add', title: 'Home page', key: 'home' },
]

const history = createBrowserHistory()


export default function MainUI(props) {
console.log(history);
const theme = useTheme();
const [open, setOpen] = React.useState(false);
const [currentTitle, setCurrentTitle] = React.useState();



  return (
        <Box sx={{display: 'flex'}}>
        <CssBaseline />
            <AppBar theme={theme} open={open} setOpen={setOpen} currentTitle={currentTitle}/>
            <Drawer  theme={theme} open={open} setOpen={setOpen} setCurrentTitle={setCurrentTitle}/>
            <BodySection  theme={theme} open={open} setOpen={setOpen}>
              {props.children}
            </BodySection>

        </Box>
  )
}
