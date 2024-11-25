using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium51";
        public override double halfLife { get; } = 345.6d;
        public override double atomicWeight { get; } = 50.94661d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium51() }, { 1.0d, new BetaParticle(-1, 1235055.0) }, { 0.9309999999999999d, new GammaParticle(320076.0, 0.00387) }, { 0.0118237d, new GammaParticle(608550.0, 0.00204) }, { 0.068894d, new GammaParticle(928630.0, 0.00134) }, { 9.838084117000439e-06d, new GammaParticle(536.0, 2.31314) }, { 0.00012027374008201312d, new GammaParticle(4945.0, 0.25073) }, { 0.00023661959488887097d, new GammaParticle(4952.0, 0.25037) }, { 4.760957088511594e-05d, new GammaParticle(5444.0, 0.22774) }, { 4.760957088511594e-05d, new GammaParticle(5444.0, 0.22774) } } },

        };
    }
}
    