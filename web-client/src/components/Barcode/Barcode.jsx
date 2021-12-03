import React, { useEffect } from "react";
import BarcodeComponent from "react-barcode";
import { useParams } from "react-router-dom";

export const Barcode = () => {
  const { orderNum } = useParams();

  return (
    <div className="mx-auto w-50 mt-3">
      <div className="card border border-3 rounded-3">
        <div className="card-body">
          <div className="card-title fs-1">Código de barras</div>
          <BarcodeComponent
            height={200}
            width={8}
            fontSize={40}
            value={orderNum}
          />
        </div>
      </div>
    </div>
  );
};
