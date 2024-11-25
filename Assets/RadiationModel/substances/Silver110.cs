using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver110 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver110";
        public override double halfLife { get; } = 24.56d;
        public override double atomicWeight { get; } = 109.90611d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium110() }, { 1.0d, new BetaParticle(-1, 1445350.0) }, { 1e-06d, new GammaParticle(255400.0, 0.00485) }, { 7.6e-05d, new GammaParticle(295300.0, 0.0042) }, { 8.5e-07d, new GammaParticle(295420.0, 0.0042) }, { 4.5000000000000003e-07d, new GammaParticle(310400.0, 0.00399) }, { 1.7e-05d, new GammaParticle(548400.0, 0.00226) }, { 3.5e-06d, new GammaParticle(603030.0, 0.00206) }, { 0.045d, new GammaParticle(657500.0, 0.00189) }, { 0.00038199999999999996d, new GammaParticle(815500.0, 0.00152) }, { 8.999999999999999e-05d, new GammaParticle(818200.0, 0.00152) }, { 9e-06d, new GammaParticle(1074000.0, 0.00115) }, { 0.000153d, new GammaParticle(1125800.0, 0.0011) }, { 2.7000000000000002e-05d, new GammaParticle(1186300.0, 0.00105) }, { 2.2000000000000003e-05d, new GammaParticle(1421400.0, 0.00087) }, { 4.9e-05d, new GammaParticle(1475800.0, 0.00084) }, { 2.2000000000000003e-05d, new GammaParticle(1629900.0, 0.00076) }, { 7.2e-05d, new GammaParticle(1674300.0, 0.00074) }, { 5.1000000000000006e-05d, new GammaParticle(1783600.0, 0.0007) }, { 3.6e-05d, new GammaParticle(2004400.0, 0.00062) }, { 8.5764412042152e-06d, new GammaParticle(3388.0, 0.36595) }, { 3.0250416483924483e-05d, new GammaParticle(22983.0, 0.05395) }, { 5.689376807207914e-05d, new GammaParticle(23173.0, 0.0535) }, { 1.5858472164125536e-05d, new GammaParticle(26184.0, 0.04735) }, { 1.874471409799638e-05d, new GammaParticle(26381.0, 0.047) }, { 2.8862419338708472e-06d, new GammaParticle(26641.0, 0.04654) } } },
            { 0.003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium110() }, { 0.0002d, new GammaParticle(373800.0, 0.00332) }, { 0.00016d, new GammaParticle(3053.0, 0.40611) }, { 0.00063d, new GammaParticle(21020.0, 0.05898) }, { 0.0011799999999999998d, new GammaParticle(21177.0, 0.05855) }, { 0.00032d, new GammaParticle(23904.0, 0.05187) }, { 0.00037999999999999997d, new GammaParticle(24070.0, 0.05151) }, { 5.4999999999999995e-05d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    