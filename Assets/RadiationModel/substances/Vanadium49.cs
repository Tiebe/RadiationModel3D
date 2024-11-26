using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium49";
        public override double halfLife { get; } = 28512000.0d;
        public override double atomicWeight { get; } = 48.94851d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium49() }, { 0.004780615764000001d, new GammaParticle(477.0, 2.59925) }, { 0.05996050400707057d, new GammaParticle(4505.0, 0.27521) }, { 0.11812550040794045d, new GammaParticle(4511.0, 0.27485) }, { 0.02359639558498896d, new GammaParticle(4947.0, 0.25063) }, { 0.02359639558498896d, new GammaParticle(4947.0, 0.25063) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    