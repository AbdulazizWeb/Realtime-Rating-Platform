import React from 'react'

const Link = (props) => {
  return (
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
  )
}
export default Link
