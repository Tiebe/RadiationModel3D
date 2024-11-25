using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium76m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium76m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 75.93541d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium76() }, { 0.79d, new GammaParticle(70550.0, 0.01757) }, { 0.75d, new GammaParticle(101300.0, 0.01224) }, { 0.82d, new GammaParticle(145110.0, 0.00854) }, { 0.14d, new GammaParticle(246320.0, 0.00503) }, { 0.009428188245d, new GammaParticle(1767.0, 0.70166) }, { 0.06287725495601632d, new GammaParticle(13336.0, 0.09297) }, { 0.12103417700869358d, new GammaParticle(13396.0, 0.09255) }, { 0.029465379959937386d, new GammaParticle(15021.0, 0.08254) }, { 0.03288336403529013d, new GammaParticle(15070.0, 0.08227) }, { 0.0034179840753527373d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    