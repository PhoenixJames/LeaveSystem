import * as React from 'react';
import {useNavigate, Link} from "react-router-dom";
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import Toolbar from '@mui/material/Toolbar';
import List from '@mui/material/List';
import Divider from '@mui/material/Divider';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import ArrowLeft from '@mui/icons-material/ArrowLeft';

const drawerWidth = 240;

export default function ClippedDrawer() {
  const navigate = useNavigate();
  const goTo = (path) => {
    navigate(path);
  }

  return (
    <Drawer
      variant="permanent"
      sx={{
        width: drawerWidth,
        flexShrink: 0,
        [`& .MuiDrawer-paper`]: {width: drawerWidth, boxSizing: 'border-box'},
      }}
    >
      <Toolbar />
      <Box sx={{overflow: 'auto'}}>
        <List>
          <ListItem disablePadding>
            <ListItemButton>
              <ListItemIcon>
                <ArrowLeft />
              </ListItemIcon>
              <ListItemText>
                <Link to="/registeremployee">Register Employee</Link>
              </ListItemText>
            </ListItemButton>
          </ListItem>
          <ListItem disablePadding>
            <ListItemButton>
              <ListItemIcon>
                <ArrowLeft />
              </ListItemIcon>
              <ListItemText>
                <Link to="/viewemployee">View Employee</Link>
              </ListItemText>
            </ListItemButton>
          </ListItem>
        </List>
      </Box>
    </Drawer>
  );
}
