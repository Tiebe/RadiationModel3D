using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium110";
        public override double halfLife { get; } = 12.04d;
        public override double atomicWeight { get; } = 109.91404d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium110() }, { 1.0d, new BetaParticle(-1, 1378000.0) }, { 0.00368d, new GammaParticle(54000.0, 0.02296) }, { 0.00207d, new GammaParticle(85400.0, 0.01452) }, { 0.00207d, new GammaParticle(88200.0, 0.01406) }, { 0.0115d, new GammaParticle(96000.0, 0.01292) }, { 0.23d, new GammaParticle(112200.0, 0.01105) }, { 0.00414d, new GammaParticle(116100.0, 0.01068) }, { 0.00322d, new GammaParticle(139400.0, 0.00889) }, { 0.00598d, new GammaParticle(166100.0, 0.00746) }, { 0.00483d, new GammaParticle(251600.0, 0.00493) }, { 0.00391d, new GammaParticle(415400.0, 0.00298) }, { 0.00184d, new GammaParticle(554800.0, 0.00223) }, { 0.002722244304d, new GammaParticle(2892.0, 0.42871) }, { 0.011507184689273078d, new GammaParticle(20073.0, 0.06177) }, { 0.021785658253072847d, new GammaParticle(20215.0, 0.06133) }, { 0.00591618958632425d, new GammaParticle(22806.0, 0.05436) }, { 0.006898277057654074d, new GammaParticle(22957.0, 0.05401) }, { 0.0009820874713298256d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    