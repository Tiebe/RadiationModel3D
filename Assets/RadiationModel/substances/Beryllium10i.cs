using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium10i : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium10i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 10.03627d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium9() }, { 1.0d, new NeutronParticle() } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lithium9() }, { 1.0d, new ProtonParticle() } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    