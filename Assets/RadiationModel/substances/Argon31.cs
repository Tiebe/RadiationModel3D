using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon31 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon31";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 31.01216d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur31()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.69578d, new GammaParticle(511000.0, 0.00243)), new(6.47013824e-08d, new GammaParticle(223.0, 5.55983)), new(9.076696668839035e-07d, new GammaParticle(2621.0, 0.47304)), new(1.7952327272229105e-06d, new GammaParticle(2623.0, 0.47268)), new(2.3244960589318602e-07d, new GammaParticle(2816.0, 0.44028)), new(2.3244960589318602e-07d, new GammaParticle(2816.0, 0.44028)) } },
            { 0.6829999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur30()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },
            { 0.08900000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Phosphorus29()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    