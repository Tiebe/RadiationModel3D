using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium7 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium7";
        public override double halfLife { get; } = 4598208.0d;
        public override double atomicWeight { get; } = 7.01693d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lithium7() }, { 0.10439999999999999d, new GammaParticle(477603.5, 0.0026) } } },

        };
    }
}
    