using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium119";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 118.95688d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium119() }, { 1.0d, new BetaParticle(-1, 5955000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    