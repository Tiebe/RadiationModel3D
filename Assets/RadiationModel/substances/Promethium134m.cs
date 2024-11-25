using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium134m";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 133.92838d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium134() }, { 1.0d, new BetaParticle(1, 5909000.0) }, { 0.8540000000000001d, new GammaParticle(294400.0, 0.00421) }, { 0.75d, new GammaParticle(294400.0, 0.00421) }, { 0.02928d, new GammaParticle(335300.0, 0.0037) }, { 0.0525d, new GammaParticle(335300.0, 0.0037) }, { 0.08784d, new GammaParticle(459400.0, 0.0027) }, { 0.1725d, new GammaParticle(459400.0, 0.0027) }, { 0.64782d, new GammaParticle(494900.0, 0.00251) }, { 0.0225d, new GammaParticle(494900.0, 0.00251) }, { 0.08662d, new GammaParticle(516000.0, 0.0024) }, { 0.06344d, new GammaParticle(524400.0, 0.00236) }, { 0.122d, new GammaParticle(559400.0, 0.00222) }, { 0.0225d, new GammaParticle(594700.0, 0.00208) }, { 0.042699999999999995d, new GammaParticle(597200.0, 0.00208) }, { 0.06344d, new GammaParticle(608600.0, 0.00204) }, { 0.17324d, new GammaParticle(631200.0, 0.00196) }, { 0.185d, new GammaParticle(753800.0, 0.00164) }, { 0.09394d, new GammaParticle(753800.0, 0.00164) }, { 0.2275d, new GammaParticle(794700.0, 0.00156) }, { 0.122d, new GammaParticle(794700.0, 0.00156) }, { 0.02928d, new GammaParticle(851300.0, 0.00146) }, { 0.02196d, new GammaParticle(881900.0, 0.00141) }, { 0.06831999999999999d, new GammaParticle(1167100.0, 0.00106) }, { 0.0366d, new GammaParticle(1247400.0, 0.00099) }, { 0.045d, new GammaParticle(1375000.0, 0.0009) }, { 0.0375d, new GammaParticle(1384000.0, 0.0009) }, { 0.04392d, new GammaParticle(1442600.0, 0.00086) }, { 1.808d, new GammaParticle(511000.0, 0.00243) }, { 1.96d, new GammaParticle(511000.0, 0.00243) }, { 0.013082719503839999d, new GammaParticle(5870.0, 0.21122) }, { 0.0096793403d, new GammaParticle(5870.0, 0.21122) }, { 0.017314436987396417d, new GammaParticle(36848.0, 0.03365) }, { 0.023489446124854124d, new GammaParticle(36848.0, 0.03365) }, { 0.031532392983785136d, new GammaParticle(37362.0, 0.03318) }, { 0.04277808436505942d, new GammaParticle(37362.0, 0.03318) }, { 0.013137524739925582d, new GammaParticle(42380.0, 0.02926) }, { 0.009683874326824538d, new GammaParticle(42380.0, 0.02926) }, { 0.016513868598086453d, new GammaParticle(42810.0, 0.02896) }, { 0.012172630028818443d, new GammaParticle(42810.0, 0.02896) }, { 0.002488755701993906d, new GammaParticle(43335.0, 0.02861) }, { 0.0033763438581608744d, new GammaParticle(43335.0, 0.02861) } } },

        };
    }
}
    