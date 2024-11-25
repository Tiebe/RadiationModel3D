using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold192m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold192m";
        public override double halfLife { get; } = 0.029d;
        public override double atomicWeight { get; } = 191.96496d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold192() } } },

        };
    }
}
    