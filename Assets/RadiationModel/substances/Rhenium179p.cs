using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium179p : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium179p";
        public override double halfLife { get; } = 0.00047d;
        public override double atomicWeight { get; } = 178.9558d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium179() } } },

        };
    }
}
    