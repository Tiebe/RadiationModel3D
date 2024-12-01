using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon132m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon132m";
        public override double halfLife { get; } = 0.00839d;
        public override double atomicWeight { get; } = 131.90711d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon132()), new(0.96d, new GammaParticle(173600.0, 0.00714)), new(0.98d, new GammaParticle(538100.0, 0.0023)), new(0.97d, new GammaParticle(600100.0, 0.00207)), new(0.98d, new GammaParticle(667750.0, 0.00186)), new(1.0d, new GammaParticle(772600.0, 0.0016)), new(0.023848991039d, new GammaParticle(4540.0, 0.27309)), new(0.0551207602078331d, new GammaParticle(29458.0, 0.04209)), new(0.10211330160769379d, new GammaParticle(29778.0, 0.04164)), new(0.029602238013327762d, new GammaParticle(33726.0, 0.03676)), new(0.036588366184473115d, new GammaParticle(34030.0, 0.03643)), new(0.006986128171145352d, new GammaParticle(34414.0, 0.03603)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    