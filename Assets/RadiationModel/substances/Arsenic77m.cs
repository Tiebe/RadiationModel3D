using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Arsenic77m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic77m";
        public override double halfLife { get; } = 0.00011d;
        public override double atomicWeight { get; } = 76.92116d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic77()), new(0.902d, new GammaParticle(211030.0, 0.00588)), new(0.954316d, new GammaParticle(264450.0, 0.00469)), new(0.032472d, new GammaParticle(475460.0, 0.00261)), new(0.00148159765032224d, new GammaParticle(1320.0, 0.93927)), new(0.011992541760216975d, new GammaParticle(10509.0, 0.11798)), new(0.0232729318071356d, new GammaParticle(10544.0, 0.11759)), new(0.005321423357725393d, new GammaParticle(11773.0, 0.10531)), new(0.005522573160647414d, new GammaParticle(11791.0, 0.10515)), new(0.00020114980292201985d, new GammaParticle(11861.0, 0.10453)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    