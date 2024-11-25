using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium84m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium84m";
        public override double halfLife { get; } = 1215.6d;
        public override double atomicWeight { get; } = 83.91487d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium84() }, { 0.31311d, new GammaParticle(215610.0, 0.00575) }, { 0.63d, new GammaParticle(248020.0, 0.005) }, { 0.33075000000000004d, new GammaParticle(463620.0, 0.00267) }, { 0.0082831523551875d, new GammaParticle(1767.0, 0.70166) }, { 0.05151030189630996d, new GammaParticle(13336.0, 0.09297) }, { 0.0991536128899133d, new GammaParticle(13396.0, 0.09255) }, { 0.02413862720768523d, new GammaParticle(15021.0, 0.08254) }, { 0.026938707963776717d, new GammaParticle(15070.0, 0.08227) }, { 0.0028000807560914862d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    