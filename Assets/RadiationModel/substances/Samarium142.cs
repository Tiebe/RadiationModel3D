using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium142";
        public override double halfLife { get; } = 4349.4d;
        public override double atomicWeight { get; } = 141.91521d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium142() }, { 1.0d, new BetaParticle(1, 3484099.99999) }, { 0.00099d, new GammaParticle(679000.0, 0.00183) }, { 0.0007920000000000001d, new GammaParticle(849000.0, 0.00146) }, { 0.00264d, new GammaParticle(1243000.0, 0.001) }, { 0.00132d, new GammaParticle(1345000.0, 0.00092) }, { 0.14800000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.1162249596027704d, new GammaParticle(6109.0, 0.20295) }, { 0.2044033767034194d, new GammaParticle(38171.0, 0.03248) }, { 0.3711027173264695d, new GammaParticle(38724.0, 0.03202) }, { 0.11505543470939626d, new GammaParticle(43934.0, 0.02822) }, { 0.14462468142971108d, new GammaParticle(44387.0, 0.02793) }, { 0.029569246720314836d, new GammaParticle(44938.0, 0.02759) } } },

        };
    }
}
    