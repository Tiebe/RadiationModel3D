using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium248";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 248.08261d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium248() } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium244() }, { 1.0d, new AlphaParticle(9517002.09) } } },

        };
    }
}
    