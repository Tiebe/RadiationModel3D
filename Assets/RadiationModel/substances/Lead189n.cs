using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead189n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead189n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 188.9835d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead189()), new(0.051d, new GammaParticle(142400.0, 0.00871)), new(0.028999999999999998d, new GammaParticle(193900.0, 0.00639)), new(0.046d, new GammaParticle(230900.0, 0.00537)), new(0.10300000000000001d, new GammaParticle(267400.0, 0.00464)), new(0.081d, new GammaParticle(272400.0, 0.00455)), new(0.037000000000000005d, new GammaParticle(279700.0, 0.00443)), new(0.026000000000000002d, new GammaParticle(323500.0, 0.00383)), new(0.028999999999999998d, new GammaParticle(325000.0, 0.00381)), new(0.43d, new GammaParticle(336700.0, 0.00368)), new(0.051d, new GammaParticle(389700.0, 0.00318)), new(0.4d, new GammaParticle(425900.0, 0.00291)), new(0.58d, new GammaParticle(468400.0, 0.00265)), new(0.028999999999999998d, new GammaParticle(473000.0, 0.00262)), new(0.059000000000000004d, new GammaParticle(481200.0, 0.00258)), new(0.073d, new GammaParticle(503800.0, 0.00246)), new(0.48d, new GammaParticle(530300.0, 0.00234)), new(0.235d, new GammaParticle(538200.0, 0.0023)), new(0.081d, new GammaParticle(609300.0, 0.00203)), new(0.059000000000000004d, new GammaParticle(637400.0, 0.00195)), new(0.294d, new GammaParticle(810800.0, 0.00153)), new(0.73d, new GammaParticle(818800.0, 0.00151)), new(0.08800000000000001d, new GammaParticle(910600.0, 0.00136)), new(0.081d, new GammaParticle(1142100.0, 0.00109)), new(0.1510458348033d, new GammaParticle(12522.0, 0.09901)), new(0.07897194155381973d, new GammaParticle(72805.0, 0.01703)), new(0.13272595219129366d, new GammaParticle(74970.0, 0.01654)), new(0.04536383437395287d, new GammaParticle(84986.0, 0.01459)), new(0.05906371235488664d, new GammaParticle(86022.0, 0.01441)), new(0.013699877980933766d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    