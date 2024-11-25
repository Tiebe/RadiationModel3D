using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel65 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel65";
        public override double halfLife { get; } = 9063.0d;
        public override double atomicWeight { get; } = 64.93008d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper65() }, { 1.0d, new BetaParticle(-1, 1068950.0) }, { 0.048052830000000005d, new GammaParticle(366270.0, 0.00339) }, { 0.00292516d, new GammaParticle(507900.0, 0.00244) }, { 0.001545145d, new GammaParticle(609500.0, 0.00203) }, { 0.001035601d, new GammaParticle(770600.0, 0.00161) }, { 0.00096719d, new GammaParticle(852700.0, 0.00145) }, { 3.5385e-05d, new GammaParticle(954500.0, 0.0013) }, { 0.15427860000000002d, new GammaParticle(1115530.0, 0.00111) }, { 0.2359d, new GammaParticle(1481840.0, 0.00084) }, { 0.00497749d, new GammaParticle(1623420.0, 0.00076) }, { 0.00398671d, new GammaParticle(1724920.0, 0.00072) }, { 1.9890516821741762e-06d, new GammaParticle(952.0, 1.30236) }, { 1.9033584306937818e-05d, new GammaParticle(8028.0, 0.15444) }, { 3.7080818832919964e-05d, new GammaParticle(8048.0, 0.15406) }, { 7.805513476754218e-06d, new GammaParticle(8940.0, 0.13868) }, { 7.805513476754218e-06d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    