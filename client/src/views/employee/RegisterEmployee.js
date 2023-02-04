import { FormControl, TextField } from '@mui/material';
import * as React from 'react';

export default function RegisterEmployee() {
  return (
    <div>
      <FormControl>
        <TextField id="outlined-basic" label="Outlined" variant="outlined" />
        <TextField id="outlined-basic" label="Outlined" variant="outlined" />
        <TextField id="outlined-basic" label="Outlined" variant="outlined" />
        <TextField id="outlined-basic" label="Outlined" variant="outlined" />
      </FormControl>
    </div>
  );
}
