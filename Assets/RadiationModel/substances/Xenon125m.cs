using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon125m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon125m";
        public override double halfLife { get; } = 57.0d;
        public override double atomicWeight { get; } = 124.90666d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon125()), new(0.602d, new GammaParticle(111300.0, 0.01114)), new(0.19926200000000002d, new GammaParticle(141400.0, 0.00877)), new(0.0985225786972d, new GammaParticle(4540.0, 0.27309)), new(0.1781604004714876d, new GammaParticle(29458.0, 0.04209)), new(0.33004890787604224d, new GammaParticle(29778.0, 0.04164)), new(0.09567985926575259d, new GammaParticle(33726.0, 0.03676)), new(0.1182603060524702d, new GammaParticle(34030.0, 0.03643)), new(0.022580446786717615d, new GammaParticle(34414.0, 0.03603)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    