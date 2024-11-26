using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium179m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium179m";
        public override double halfLife { get; } = 18.67d;
        public override double atomicWeight { get; } = 178.94623d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium179()), new(0.0287806d, new GammaParticle(160696.0, 0.00772)), new(0.953d, new GammaParticle(214335.0, 0.00578)), new(4.765e-05d, new GammaParticle(375000.0, 0.00331)), new(0.21261641874772d, new GammaParticle(9114.0, 0.13604)), new(0.1616939921644092d, new GammaParticle(54608.0, 0.0227)), new(0.2829786352194771d, new GammaParticle(55786.0, 0.02222)), new(0.09335668420214187d, new GammaParticle(63333.0, 0.01958)), new(0.11828291888411374d, new GammaParticle(64057.0, 0.01936)), new(0.024926234681971877d, new GammaParticle(64935.0, 0.01909)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    