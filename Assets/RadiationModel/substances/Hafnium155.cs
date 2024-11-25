using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium155";
        public override double halfLife { get; } = 0.843d;
        public override double atomicWeight { get; } = 154.96317d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium155() }, { 1.0d, new BetaParticle(1, 8096500.0) } } },

        };
    }
}
    