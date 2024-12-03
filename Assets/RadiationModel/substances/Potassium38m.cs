using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium38m : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium38m";
        public override double halfLife { get; } = 0.9244d;
        public override double atomicWeight { get; } = 37.96922d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99967d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chlorine38()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.99766d, new GammaParticle(511000.0, 0.00243)), new(1.98717841564767e-06d, new GammaParticle(265.0, 4.67865)), new(2.7364451767934844e-05d, new GammaParticle(2956.0, 0.41943)), new(5.419776543461051e-05d, new GammaParticle(2958.0, 0.41915)), new(8.800563236154643e-06d, new GammaParticle(3190.0, 0.38867)), new(8.800563236154643e-06d, new GammaParticle(3190.0, 0.38867)) } },
            { 0.00033d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium38()), new(0.00024d, new GammaParticle(130100.0, 0.00953)), new(2.714470032e-07d, new GammaParticle(311.0, 3.98663)), new(3.664962587809065e-06d, new GammaParticle(3311.0, 0.37446)), new(7.250173269651958e-06d, new GammaParticle(3314.0, 0.37412)), new(1.3371041425389754e-06d, new GammaParticle(3591.0, 0.34526)), new(1.3371041425389754e-06d, new GammaParticle(3591.0, 0.34526)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    