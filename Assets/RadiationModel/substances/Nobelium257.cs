using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium257";
        public override double halfLife { get; } = 24.5d;
        public override double atomicWeight { get; } = 257.09688d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium253()), new(1.0d, new AlphaParticle(9498502.09)), new(0.019d, new GammaParticle(77000.0, 0.0161)), new(0.011000000000000001d, new GammaParticle(101800.0, 0.01218)), new(0.015d, new GammaParticle(124100.0, 0.00999)), new(0.0034000000000000002d, new GammaParticle(136400.0, 0.00909)), new(0.26934201d, new GammaParticle(20618.0, 0.06013)) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mendelevium257()) } },
            { 0.015d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    