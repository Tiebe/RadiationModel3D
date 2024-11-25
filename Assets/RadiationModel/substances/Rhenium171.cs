using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium171";
        public override double halfLife { get; } = 15.2d;
        public override double atomicWeight { get; } = 170.95572d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum171() }, { 1.0d, new BetaParticle(1, 5235000.0) }, { 0.096d, new GammaParticle(102000.0, 0.01216) }, { 0.0128d, new GammaParticle(105600.0, 0.01174) }, { 0.032d, new GammaParticle(131400.0, 0.00944) }, { 0.0512d, new GammaParticle(133400.0, 0.00929) }, { 0.0304d, new GammaParticle(207600.0, 0.00597) }, { 0.0144d, new GammaParticle(233400.0, 0.00531) }, { 0.0304d, new GammaParticle(360900.0, 0.00344) }, { 0.07519999999999999d, new GammaParticle(434900.0, 0.00285) }, { 0.0496d, new GammaParticle(466400.0, 0.00266) }, { 0.0208d, new GammaParticle(498000.0, 0.00249) }, { 0.16d, new GammaParticle(568400.0, 0.00218) }, { 0.016d, new GammaParticle(933900.0, 0.00133) }, { 0.0128d, new GammaParticle(964000.0, 0.00129) }, { 0.08d, new GammaParticle(1066000.0, 0.00116) }, { 1.242d, new GammaParticle(511000.0, 0.00243) }, { 0.225d, new GammaParticle(9740.0, 0.12729) }, { 0.221d, new GammaParticle(57983.0, 0.02138) }, { 0.384d, new GammaParticle(59320.0, 0.0209) }, { 0.127d, new GammaParticle(67335.0, 0.01841) }, { 0.162d, new GammaParticle(68117.0, 0.0182) }, { 0.0349d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    