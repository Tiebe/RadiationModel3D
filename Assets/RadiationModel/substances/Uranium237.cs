using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium237";
        public override double halfLife { get; } = 583372.8d;
        public override double atomicWeight { get; } = 237.04873d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium237() }, { 1.0d, new BetaParticle(-1, 259250.0) }, { 0.00099d, new GammaParticle(13810.0, 0.08978) }, { 0.024300000000000002d, new GammaParticle(26344.6, 0.04706) }, { 0.0013d, new GammaParticle(33196.0, 0.03735) }, { 0.00021d, new GammaParticle(38540.0, 0.03217) }, { 0.00024d, new GammaParticle(43420.0, 0.02855) }, { 0.0034000000000000002d, new GammaParticle(51010.0, 0.02431) }, { 0.345d, new GammaParticle(59540.9, 0.02082) }, { 0.01282d, new GammaParticle(64830.0, 0.01912) }, { 9.5e-06d, new GammaParticle(69760.0, 0.01777) }, { 6.4e-05d, new GammaParticle(102980.0, 0.01204) }, { 0.018600000000000002d, new GammaParticle(164610.0, 0.00753) }, { 0.212d, new GammaParticle(208005.0, 0.00596) }, { 0.000212d, new GammaParticle(221800.0, 0.00559) }, { 0.000205d, new GammaParticle(234400.0, 0.00529) }, { 0.00712d, new GammaParticle(267540.0, 0.00463) }, { 2.5e-05d, new GammaParticle(292770.0, 0.00423) }, { 2.7e-06d, new GammaParticle(309100.0, 0.00401) }, { 0.012d, new GammaParticle(332350.0, 0.00373) }, { 0.000951d, new GammaParticle(335370.0, 0.0037) }, { 8.9e-05d, new GammaParticle(337700.0, 0.00367) }, { 1.65e-05d, new GammaParticle(340450.0, 0.00364) }, { 0.000392d, new GammaParticle(368620.0, 0.00336) }, { 0.0010730000000000002d, new GammaParticle(370940.0, 0.00334) }, { 0.64d, new GammaParticle(17136.0, 0.07235) }, { 0.15643814807030015d, new GammaParticle(97078.0, 0.01277) }, { 0.24902602367128326d, new GammaParticle(101068.0, 0.01227) }, { 0.09080708012962545d, new GammaParticle(114160.0, 0.01086) }, { 0.1220447156942166d, new GammaParticle(115608.0, 0.01072) }, { 0.03123763556459115d, new GammaParticle(117470.0, 0.01055) } } },

        };
    }
}
    