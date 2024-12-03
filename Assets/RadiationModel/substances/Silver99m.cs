using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver99m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver99m";
        public override double halfLife { get; } = 10.5d;
        public override double atomicWeight { get; } = 98.91819d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver99()), new(0.3626d, new GammaParticle(163600.0, 0.00758)), new(0.98d, new GammaParticle(342600.0, 0.00362)), new(0.03321913012d, new GammaParticle(3218.0, 0.38528)), new(0.10098629424384592d, new GammaParticle(21990.0, 0.05638)), new(0.19036059235409222d, new GammaParticle(22163.0, 0.05594)), new(0.05273527547024008d, new GammaParticle(25030.0, 0.04953)), new(0.06191121340206185d, new GammaParticle(25211.0, 0.04918)), new(0.009175937931821775d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    