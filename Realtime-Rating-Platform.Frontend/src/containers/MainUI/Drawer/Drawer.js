import * as React from 'react';
import { styled } from '@mui/material/styles';
import Drawer from '@mui/material/Drawer';
import List from '@mui/material/List';
import Divider from '@mui/material/Divider';
import IconButton from '@mui/material/IconButton';
import ChevronLeftIcon from '@mui/icons-material/ChevronLeft';
import ChevronRightIcon from '@mui/icons-material/ChevronRight';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import InboxIcon from '@mui/icons-material/MoveToInbox';
import MailIcon from '@mui/icons-material/Mail';
import { Link, NavLink } from 'react-router-dom';

const drawerWidth = 300;

const DrawerHeader = styled('div')(({ theme }) => ({
    display: 'flex',
    alignItems: 'center',
    padding: theme.spacing(0, 1),
    // necessary for content to be below app bar
    ...theme.mixins.toolbar,
    justifyContent: 'flex-end',
  }));



export default function DrawerComponent(props) {
    const open = props.open;
    const setOpen = props.setOpen;
    const theme = props.theme;

  const handleDrawerClose = () => {
    setOpen(false);
  };

  const changeTitle = (title) => {
    props.setCurrentTitle(title)
  }

  return (
    <Drawer
        sx={{
          width: drawerWidth,
          flexShrink: 0,
          '& .MuiDrawer-paper': {
            width: drawerWidth,
            boxSizing: 'border-box',
          },
        }}
        variant="persistent"
        anchor="left"
        open={open}
      >
        <DrawerHeader sx={{display: 'flex', justifyContent: 'space-around'}}>
            <Link to="/" style={{textDecoration: 'none', color: 'white'}}>
                <h2>Realtime Rating</h2>
            </Link>
          <IconButton onClick={handleDrawerClose} sx={{color: 'white', fontWeight: 'bold'}}>
            {theme.direction === 'ltr' ? <ChevronLeftIcon /> : <ChevronRightIcon />}
          </IconButton>
        </DrawerHeader>
        <Divider />
        <List>
        <NavLink to="/" style={{textDecoration: 'none', color: 'white'}} >
            <ListItem key="home" disablePadding onClick={() => changeTitle("Home Page")}>
              <ListItemButton>
                <ListItemIcon sx={{color: 'white', fontWeight: 'bold'}}>
                  <InboxIcon />  
                </ListItemIcon>
                <ListItemText primary="Home" />
              </ListItemButton>
            </ListItem>
            </NavLink>


            <NavLink to="/add" style={{textDecoration: 'none', color: 'white'}}>
            <ListItem key="Add" disablePadding onClick={() => changeTitle("Add Page")}>
              <ListItemButton>
                <ListItemIcon sx={{color: 'white'}}>
                  <MailIcon />
                </ListItemIcon>
                <ListItemText primary="Add" />
              </ListItemButton>
            </ListItem>
            </NavLink>

           
        </List>
        <Divider />
        
      </Drawer>
  )
}
