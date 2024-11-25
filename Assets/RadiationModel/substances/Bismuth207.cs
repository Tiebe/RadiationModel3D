using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth207 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth207";
        public override double halfLife { get; } = 995621014.49838d;
        public override double atomicWeight { get; } = 206.97847d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium207() }, { 1.0d, new BetaParticle(1, 489700.0) }, { 6.9e-06d, new GammaParticle(328100.0, 0.00378) }, { 0.9775d, new GammaParticle(569698.0, 0.00218) }, { 0.00128d, new GammaParticle(897770.0, 0.00138) }, { 0.745d, new GammaParticle(1063656.0, 0.00117) }, { 0.00131d, new GammaParticle(1442200.0, 0.00086) }, { 0.0161d, new GammaParticle(1460000.0, 0.00085) }, { 0.0687d, new GammaParticle(1770228.0, 0.0007) }, { 0.0007599999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.3318940489011642d, new GammaParticle(12522.0, 0.09901) }, { 0.21710873162133087d, new GammaParticle(72805.0, 0.01703) }, { 0.3648886245736653d, new GammaParticle(74970.0, 0.01654) }, { 0.12471371918464202d, new GammaParticle(84986.0, 0.01459) }, { 0.1623772623784039d, new GammaParticle(86022.0, 0.01441) }, { 0.03766354319376189d, new GammaParticle(87301.0, 0.0142) } } },

        };
    }
}
    