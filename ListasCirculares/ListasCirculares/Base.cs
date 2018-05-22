﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Base
    {
        private string _nombreBase;
        private string _nombreRuta;
        private string _baseFinal;
        private int _horaInicio;
        private int _horaFinal;

        private Base _siguiente;
        

        private int _tiempo;
        

        public Base(string nb, string nr, string bf, int hi, int hf)
        {
            _nombreBase = nb;
            _nombreRuta = nr;
            _baseFinal = bf;
            _horaInicio = hi;
            _horaFinal = hf;

            _tiempo = 0;
        }

        public int tiempoTranscurrido()
        {
            _tiempo = _horaInicio + _horaFinal;

            return _tiempo;
        }

        public string NombreBase
        {
            get { return _nombreBase; }
            set { _nombreBase = value; }
        }

        public string NombreRuta
        {
            get { return _nombreRuta; }
            set { _nombreRuta = value; }
        }

        public string BaseFinal
        {
            get { return _baseFinal; }
            set { _baseFinal = value; }
        }

        public int HoraInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }

        public int HoraFinal
        {
            get { return _horaFinal; }
            set { _horaFinal = value; }
        }

        public Base Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public override string ToString()
        {
            return "Ruta: " + _nombreRuta + " | " + "Hora de inicio: " + _horaInicio + " | "
                + "En la base: " + _nombreBase + " | " + "Finalizó: " + _horaFinal
                + " | " + "En la base: " + _baseFinal + " | " + "Con un tiempo de: " + _tiempo;
        }
    }
}