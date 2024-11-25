using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium243";
        public override double halfLife { get; } = 17841.6d;
        public override double atomicWeight { get; } = 243.062d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium243() }, { 1.0d, new BetaParticle(-1, 289800.0) }, { 0.00759d, new GammaParticle(41800.0, 0.02966) }, { 0.000805d, new GammaParticle(42200.0, 0.02938) }, { 0.00023d, new GammaParticle(54000.0, 0.02296) }, { 0.0023d, new GammaParticle(67000.0, 0.01851) }, { 0.23d, new GammaParticle(84000.0, 0.01476) }, { 0.000138d, new GammaParticle(96400.0, 0.01286) }, { 0.000391d, new GammaParticle(101300.0, 0.01224) }, { 0.00161d, new GammaParticle(109200.0, 0.01135) }, { 0.000276d, new GammaParticle(322300.0, 0.00385) }, { 1.4950000000000001e-05d, new GammaParticle(343000.0, 0.00361) }, { 0.001334d, new GammaParticle(356400.0, 0.00348) }, { 0.00575d, new GammaParticle(381600.0, 0.00325) }, { 4.83e-05d, new GammaParticle(388900.0, 0.00319) }, { 1.15e-05d, new GammaParticle(407200.0, 0.00304) }, { 0.0001311d, new GammaParticle(423200.0, 0.00293) }, { 2.3e-06d, new GammaParticle(448700.0, 0.00276) }, { 2.3e-06d, new GammaParticle(465700.0, 0.00266) }, { 0.078d, new GammaParticle(18078.0, 0.06858) }, { 0.00122d, new GammaParticle(102031.0, 0.01215) }, { 0.00193d, new GammaParticle(106468.0, 0.01165) }, { 0.0007099999999999999d, new GammaParticle(120157.0, 0.01032) }, { 0.00096d, new GammaParticle(121688.0, 0.01019) }, { 0.00025d, new GammaParticle(123677.0, 0.01002) } } },

        };
    }
}
    