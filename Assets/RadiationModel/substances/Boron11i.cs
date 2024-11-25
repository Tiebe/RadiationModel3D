using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron11i : RadioactiveSubstance
    {
        public override string name { get; } = "Boron11i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 11.02279d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium10() }, { 1.0d, new ProtonParticle() } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lithium7() }, { 1.0d, new AlphaParticle(4917897.090000001) } } },
            { 6e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron11() } } },

        };
    }
}
    