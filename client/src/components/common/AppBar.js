import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';

export default function AppNavBar() {
  return (
    <AppBar position="fixed" sx={{zIndex: (theme) => theme.zIndex.drawer + 1}}>
      <Toolbar>
        <Typography variant="h6" noWrap component="div">
          Leave System
        </Typography>
      </Toolbar>
    </AppBar>
  );
}
