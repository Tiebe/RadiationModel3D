using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium159";
        public override double halfLife { get; } = 5.6d;
        public override double atomicWeight { get; } = 158.954d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.65d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium159() }, { 1.0d, new BetaParticle(1, 6490500.0) } } },
            { 0.35d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium155() }, { 1.0d, new AlphaParticle(6247002.09) } } },

        };
    }
}
    