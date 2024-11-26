using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium145";
        public override double halfLife { get; } = 29376000.0d;
        public override double atomicWeight { get; } = 144.91342d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium145()), new(0.1215d, new GammaParticle(61226.5, 0.02025)), new(5.2245e-07d, new GammaParticle(431400.0, 0.00287)), new(3.2805e-05d, new GammaParticle(492550.0, 0.00252)), new(0.222751948441968d, new GammaParticle(6109.0, 0.20295)), new(0.3884687524970449d, new GammaParticle(38171.0, 0.03248)), new(0.7052809595080699d, new GammaParticle(38724.0, 0.03202)), new(0.21866292969521509d, new GammaParticle(43934.0, 0.02822)), new(0.27485930262688535d, new GammaParticle(44387.0, 0.02793)), new(0.056196372931670284d, new GammaParticle(44938.0, 0.02759)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    