using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin123m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin123m";
        public override double halfLife { get; } = 2403.6d;
        public override double atomicWeight { get; } = 122.90575d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony123() }, { 1.0d, new BetaParticle(-1, 716400.00001) }, { 0.8569d, new GammaParticle(160340.0, 0.00773) }, { 3e-05d, new GammaParticle(170150.0, 0.00729) }, { 0.0004d, new GammaParticle(381750.0, 0.00325) }, { 0.00017999999999999998d, new GammaParticle(541950.0, 0.00229) }, { 7.7e-05d, new GammaParticle(552370.0, 0.00224) }, { 0.01034152598474d, new GammaParticle(3941.0, 0.3146) }, { 0.030510846353020274d, new GammaParticle(26111.0, 0.04748) }, { 0.05696573254858154d, new GammaParticle(26359.0, 0.04704) }, { 0.01620527178326277d, new GammaParticle(29821.0, 0.04158) }, { 0.019559763042398166d, new GammaParticle(30069.0, 0.04123) }, { 0.0033544912591353935d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    