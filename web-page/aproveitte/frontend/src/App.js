import React from 'react';
import './App.css';
import { FaCarrot } from 'react-icons/fa';
import Conversor from './components/Conversor';

function App() {
  return (
    <main>
      <section>
      <h1>Aproveitte <FaCarrot /></h1>
      </section>
      <section>
        <Conversor />
      </section>
    </main>    
  );
}

export default App;
