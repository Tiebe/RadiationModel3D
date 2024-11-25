using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium51";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 50.961d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium51() }, { 1.0d, new BetaParticle(-1, 3459050.0) }, { 0.001725d, new GammaParticle(352400.0, 0.00352) }, { 0.03795d, new GammaParticle(532200.0, 0.00233) }, { 0.19665d, new GammaParticle(547700.0, 0.00226) }, { 0.345d, new GammaParticle(861600.0, 0.00144) }, { 0.2346d, new GammaParticle(1167500.0, 0.00106) }, { 0.04485d, new GammaParticle(1314800.0, 0.00094) }, { 0.138d, new GammaParticle(1323700.0, 0.00094) }, { 0.26565d, new GammaParticle(1394000.0, 0.00089) }, { 0.02415d, new GammaParticle(1424000.0, 0.00087) }, { 0.22425d, new GammaParticle(1480100.0, 0.00084) }, { 0.16215d, new GammaParticle(1485300.0, 0.00083) }, { 0.0483d, new GammaParticle(1644400.0, 0.00075) }, { 0.07934999999999999d, new GammaParticle(1714800.0, 0.00072) }, { 0.0621d, new GammaParticle(1847100.0, 0.00067) }, { 0.03795d, new GammaParticle(1996500.0, 0.00062) }, { 0.00897d, new GammaParticle(2027500.0, 0.00061) }, { 0.01242d, new GammaParticle(2333400.0, 0.00053) }, { 0.011385000000000001d, new GammaParticle(2378700.0, 0.00052) }, { 0.014145000000000001d, new GammaParticle(2912000.0, 0.00043) }, { 0.02415d, new GammaParticle(3038900.0, 0.00041) }, { 0.03105d, new GammaParticle(3196500.0, 0.00039) }, { 0.0207d, new GammaParticle(3771700.0, 0.00033) }, { 0.01173d, new GammaParticle(4379000.0, 0.00028) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    