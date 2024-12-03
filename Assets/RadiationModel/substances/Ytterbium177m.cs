using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium177m";
        public override double halfLife { get; } = 6.41d;
        public override double atomicWeight { get; } = 176.94562d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium177()), new(0.7663d, new GammaParticle(104500.0, 0.01186)), new(0.1255d, new GammaParticle(227000.0, 0.00546)), new(0.2144435206004d, new GammaParticle(8502.0, 0.14583)), new(0.2119682206120234d, new GammaParticle(51354.0, 0.02414)), new(0.37364396370883735d, new GammaParticle(52389.0, 0.02367)), new(0.12264883257663704d, new GammaParticle(59481.0, 0.02084)), new(0.1546601778791393d, new GammaParticle(60151.0, 0.02061)), new(0.03201134530250227d, new GammaParticle(60961.0, 0.02034)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    