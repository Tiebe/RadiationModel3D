using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium117m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 116.93633d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium117() }, { 0.02613d, new GammaParticle(57800.0, 0.02145) }, { 0.18760000000000002d, new GammaParticle(82500.0, 0.01503) }, { 0.1809d, new GammaParticle(102900.0, 0.01205) }, { 0.03417d, new GammaParticle(127400.0, 0.00973) }, { 0.67d, new GammaParticle(184600.0, 0.00672) }, { 0.0027917214012000004d, new GammaParticle(2737.0, 0.45299) }, { 0.01254526765900521d, new GammaParticle(19150.0, 0.06474) }, { 0.02380506197154689d, new GammaParticle(19279.0, 0.06431) }, { 0.006397282624309728d, new GammaParticle(21736.0, 0.05704) }, { 0.007433642409447903d, new GammaParticle(21875.0, 0.05668) }, { 0.001036359785138176d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    