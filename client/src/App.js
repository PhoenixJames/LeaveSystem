import * as React from 'react';
import {Routes, Route, Redirect} from "react-router-dom";
import Box from '@mui/material/Box';
import CssBaseline from '@mui/material/CssBaseline';
import Toolbar from '@mui/material/Toolbar';
import Drawer from './components/common/Drawer';
import AppBar from './components/common/AppBar';
import RegisterEmployee from './views/employee/RegisterEmployee';
import ViewEmployee from './views/employee/ViewEmployee';

export default function App() {
  return (
    <Box sx={{display: 'flex'}}>
      <CssBaseline />
      <AppBar />
      <Drawer />
      <Box component="main" sx={{flexGrow: 1, p: 3}}>
        <Toolbar />
        <Routes>
          <Route path="/registeremployee" element={<RegisterEmployee />} />
          <Route path="/viewemployee" element={<ViewEmployee />} />
        </Routes>
      </Box>
    </Box>
  );
}
