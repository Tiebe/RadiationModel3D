using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine17 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine17";
        public override double halfLife { get; } = 64.49d;
        public override double atomicWeight { get; } = 17.0021d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen17() }, { 1.0d, new BetaParticle(1, -2959150.0) }, { 1.997768d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    