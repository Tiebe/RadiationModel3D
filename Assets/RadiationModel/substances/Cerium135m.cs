using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium135m";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 134.90964d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium135() }, { 0.21266d, new GammaParticle(82400.0, 0.01505) }, { 0.217d, new GammaParticle(150300.0, 0.00825) }, { 0.75299d, new GammaParticle(212900.0, 0.00582) }, { 0.18445d, new GammaParticle(295800.0, 0.00419) }, { 0.14400008896d, new GammaParticle(5410.0, 0.22918) }, { 0.20737098501731932d, new GammaParticle(34279.0, 0.03617) }, { 0.3798003388595592d, new GammaParticle(34720.0, 0.03571) }, { 0.11439071325607769d, new GammaParticle(39366.0, 0.0315) }, { 0.1434459544231214d, new GammaParticle(39753.0, 0.03119) }, { 0.029055241167043735d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    