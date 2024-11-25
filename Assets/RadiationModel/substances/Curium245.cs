using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium245";
        public override double halfLife { get; } = 265803987483.9884d;
        public override double atomicWeight { get; } = 245.06549d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium241() }, { 1.0d, new AlphaParticle(6646402.09) }, { 0.0036464999999999996d, new GammaParticle(41930.0, 0.02957) }, { 0.0007312499999999999d, new GammaParticle(53730.0, 0.02308) }, { 0.00033637500000000003d, new GammaParticle(56890.0, 0.02179) }, { 0.00017549999999999998d, new GammaParticle(65440.0, 0.01895) }, { 6.825e-05d, new GammaParticle(69170.0, 0.01792) }, { 0.0012870000000000002d, new GammaParticle(79270.0, 0.01564) }, { 0.0001092d, new GammaParticle(95786.0, 0.01294) }, { 6.825e-05d, new GammaParticle(126090.0, 0.00983) }, { 0.0281775d, new GammaParticle(133080.0, 0.00932) }, { 0.001131d, new GammaParticle(136127.0, 0.00911) }, { 7.8e-05d, new GammaParticle(139870.0, 0.00886) }, { 6.63e-05d, new GammaParticle(161730.0, 0.00767) }, { 0.09847500000000001d, new GammaParticle(175010.0, 0.00708) }, { 0.00203775d, new GammaParticle(189965.0, 0.00653) }, { 8.774999999999999e-05d, new GammaParticle(205404.0, 0.00604) }, { 0.000119925d, new GammaParticle(231960.0, 0.00535) }, { 0.00018525d, new GammaParticle(388160.0, 0.00319) }, { 0.5299729350189787d, new GammaParticle(17604.0, 0.07043) }, { 0.19080415437365034d, new GammaParticle(99533.0, 0.01246) }, { 0.30204868509363675d, new GammaParticle(103741.0, 0.01195) }, { 0.11086444718529175d, new GammaParticle(117130.0, 0.01059) }, { 0.14933441035858797d, new GammaParticle(118619.0, 0.01045) }, { 0.038469963173296234d, new GammaParticle(120544.0, 0.01029) } } },
            { 6e-09d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    