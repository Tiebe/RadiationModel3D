using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium132m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium132m";
        public override double halfLife { get; } = 0.0094d;
        public override double atomicWeight { get; } = 131.91398d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium132()), new(0.0007636d, new GammaParticle(10000.0, 0.12398)), new(0.92d, new GammaParticle(325500.0, 0.00381)), new(0.046d, new GammaParticle(377200.0, 0.00329)), new(0.0184d, new GammaParticle(431000.0, 0.00288)), new(0.046d, new GammaParticle(496900.0, 0.0025)), new(0.0092d, new GammaParticle(524500.0, 0.00236)), new(0.276d, new GammaParticle(526300.0, 0.00236)), new(0.6992d, new GammaParticle(533000.0, 0.00233)), new(0.0092d, new GammaParticle(561800.0, 0.00221)), new(0.2024d, new GammaParticle(614500.0, 0.00202)), new(0.644d, new GammaParticle(683500.0, 0.00181)), new(0.0184d, new GammaParticle(788000.0, 0.00157)), new(0.6256d, new GammaParticle(798000.0, 0.00155)), new(0.046d, new GammaParticle(822400.0, 0.00151)), new(0.1564d, new GammaParticle(874100.0, 0.00142)), new(0.046d, new GammaParticle(955000.0, 0.0013)), new(0.007167648792d, new GammaParticle(5410.0, 0.22918)), new(0.010536364734942958d, new GammaParticle(34279.0, 0.03617)), new(0.019297371309419335d, new GammaParticle(34720.0, 0.03571)), new(0.0058121066312900385d, new GammaParticle(39366.0, 0.0315)), new(0.007288381715637709d, new GammaParticle(39753.0, 0.03119)), new(0.0014762750843476697d, new GammaParticle(40229.0, 0.03082)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    