import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { Link } from 'react-router-dom'
import { Button, Stack } from '@mui/material'
import Create from './pages/create.jsx'

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/create" element={<Create />} />
      </Routes>
    </Router>
  );
}

function Home() {
  return (
    <Stack spacing={0} sx={{ display: 'flex', flexDirection: 'column', justifyContent: 'center', alignItems: 'center' }}>
      <h1> Ticket System </h1>
      <Link to="/create">
        <Button variant="contained">Create New Ticket</Button>
      </Link>
    </Stack>
  )
}

export default App
