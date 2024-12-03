using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium94m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 93.91288d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium94()), new(0.85d, new GammaParticle(432200.0, 0.00287)), new(0.85d, new GammaParticle(769900.0, 0.00161)), new(0.15d, new GammaParticle(1202400.0, 0.00103)), new(7.733098703e-05d, new GammaParticle(2027.0, 0.61166)), new(0.00046315840456404814d, new GammaParticle(14883.0, 0.08331)), new(0.0008881273337757395d, new GammaParticle(14958.0, 0.08289)), new(0.00022299776947294565d, new GammaParticle(16803.0, 0.07379)), new(0.00025377146166021214d, new GammaParticle(16880.0, 0.07345)), new(3.07736921872665e-05d, new GammaParticle(17011.0, 0.07288)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    