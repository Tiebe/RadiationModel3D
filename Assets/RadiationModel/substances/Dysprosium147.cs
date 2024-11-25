using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium147";
        public override double halfLife { get; } = 67.0d;
        public override double atomicWeight { get; } = 146.93108d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium147() }, { 1.0d, new BetaParticle(1, 5580450.0) } } },
            { 0.0005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium146() }, { 1.0d, new BetaParticle(1, 471692051.73601) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    