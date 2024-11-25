using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium135m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 134.91825d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium135() }, { 1.0d, new BetaParticle(1, 4233500.0) } } },
            { 0.0003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium135() } } },

        };
    }
}
    