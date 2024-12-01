using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium49";
        public override double halfLife { get; } = 28512000.0d;
        public override double atomicWeight { get; } = 48.94851d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium49()), new(0.004780615764000001d, new GammaParticle(477.0, 2.59925)), new(0.05996050400707057d, new GammaParticle(4505.0, 0.27521)), new(0.11812550040794045d, new GammaParticle(4511.0, 0.27485)), new(0.02359639558498896d, new GammaParticle(4947.0, 0.25063)), new(0.02359639558498896d, new GammaParticle(4947.0, 0.25063)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    