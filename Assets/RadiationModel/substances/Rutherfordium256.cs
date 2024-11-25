using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium256";
        public override double halfLife { get; } = 0.00667d;
        public override double atomicWeight { get; } = 256.10115d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9968d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.0032d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium252() }, { 1.0d, new AlphaParticle(9948002.09) } } },

        };
    }
}
    